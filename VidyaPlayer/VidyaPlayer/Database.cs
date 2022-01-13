using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensionsAsync.Extensions;
using VidyaPlayer.Models;

namespace VidyaPlayer
{
    public class Database
    {
        private static SQLiteAsyncConnection _sqlDatabase;

        public static readonly AsyncLazy<Database> Instance = new AsyncLazy<Database>(async () =>
        {
            var instance = new Database();
            await _sqlDatabase.CreateTablesAsync(CreateFlags.None, typeof(Movie), typeof(User), typeof(UserMovies));

            return instance;
        });

        protected Database()
        {
            _sqlDatabase = new SQLiteAsyncConnection(Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "VidyaPlayer.db3"));
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _sqlDatabase.GetAllWithChildrenAsync<User>();
        }

        public async Task<User> GetUserByUsername(string username)
        {
            return await _sqlDatabase.Table<User>().FirstOrDefaultAsync(x => x.Username == username);
        }

        public async Task<User> GetUserWithChildren(User user)
        {
            return await _sqlDatabase.GetWithChildrenAsync<User>(user.Id);
        }

        public async Task<int> InsertUser(User user)
        {
            var existing = await _sqlDatabase.Table<User>().FirstOrDefaultAsync(x => x.Username == user.Username);
            if (existing == null)
                return await _sqlDatabase.InsertAsync(user);

            return -1;
        }

        public async Task<List<Movie>> GetAllMovies()
        {
            return await _sqlDatabase.Table<Movie>().ToListAsync();
        }

        public async Task<Movie> GetMovieByFilename(string filename)
        {
            return await _sqlDatabase.Table<Movie>().FirstOrDefaultAsync(x => x.Filename == filename);
        }

        public async Task<int> InsertMovie(Movie movie)
        {
            return await _sqlDatabase.InsertAsync(movie);
        }

        public async Task WatchMovie(User user, Movie movie)
        {
            user = await GetUserWithChildren(user);

            if (user.UserMovies == null)
                user.UserMovies = new List<UserMovies>();

            var userMovie = user.UserMovies.FirstOrDefault(x => x.MovieId == movie.Id);

            if (userMovie != null)
            {
                userMovie.TimesWatched++;
                await _sqlDatabase.UpdateAsync(userMovie);
            }
            else
            {
                userMovie = new UserMovies()
                {
                    Movie = movie, MovieId = movie.Id, TimesWatched = 1, UserId = user.Id
                };
                user.UserMovies.Add(userMovie);
                await _sqlDatabase.InsertAsync(userMovie);
            }

            await _sqlDatabase.UpdateWithChildrenAsync(user);
        }

        public async Task<UserMovies> GetUserMoviesWithChildren(UserMovies um)
        {
            return await _sqlDatabase.GetWithChildrenAsync<UserMovies>(um.Id);
        }
    }

    public class AsyncLazy<T>
    {
        readonly Lazy<Task<T>> instance;

        public AsyncLazy(Func<T> factory)
        {
            instance = new Lazy<Task<T>>(() => Task.Run(factory));
        }

        public AsyncLazy(Func<Task<T>> factory)
        {
            instance = new Lazy<Task<T>>(() => Task.Run(factory));
        }

        public TaskAwaiter<T> GetAwaiter()
        {
            return instance.Value.GetAwaiter();
        }
    }
}