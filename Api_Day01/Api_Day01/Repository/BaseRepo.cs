using Api_Day01.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Api_Day01.Repository
{
    public class BaseRepo<TEntity> where TEntity : class
    {
        #region initialization
        private readonly CrsDbContext DbContext;

        protected DbSet<TEntity> DbSet;
        public BaseRepo( CrsDbContext context )
        {
            DbContext = context;
            DbSet = DbContext.Set<TEntity>( );
        }
        #endregion

        #region Add()
        public void Add( TEntity entity )
        {
            try
            {
                DbContext.Add( entity );

                Save( );
            }
            catch ( Exception e )
            {
                var s = e.Message;
                throw;
            }

        }
        #endregion

        #region GetAll
        public IQueryable<TEntity> GetAll( )
        {
            IQueryable<TEntity> entities = DbSet;
            return entities;
        }
        #endregion

        #region Find()
        public TEntity Get( int id )
        {
            return DbSet.Find( id );
        }
        #endregion

        #region Delete ()
        public void Delete( int Id )
        {

            DbContext.Remove( Get( Id ) );

            Save( );
        }
        #endregion


        #region SaveChanges()
        public void Save( )
        {
            DbContext.SaveChanges( );
        }
        #endregion

        #region Update()
        public void Edit( TEntity entity )
        {
            DbContext.Entry( entity ).State = EntityState.Modified;
            Save( );
        }
        #endregion  


        #region LINQ Exepression

        #region Get all entities that match specific conditions
        public virtual IQueryable<TEntity> GetMany( Expression<Func<TEntity , bool>> where = null ,
params Expression<Func<TEntity , object>>[ ] includeProperties )
        {
            var query = where == null
                ? DbSet
                : DbSet.Where( where );
            var entities = includeProperties.Aggregate( query , ( current , includeProperty ) =>
                current.Include( includeProperty ) );


            return entities;
        }
        #endregion

        #region Get an entity on specific conditions
        public virtual TEntity GetOne( Expression<Func<TEntity , bool>> where , params Expression<Func<TEntity , object>>[ ] includeProperties )
        {
            return GetMany( where , includeProperties ).FirstOrDefault( );
        }
        #endregion

        #endregion


    }
}