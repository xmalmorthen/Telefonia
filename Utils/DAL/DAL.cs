using DAL.Classes;
using GenDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace DAL
{    
    /// <summary>
    /// DAL Genérico
    /// </summary>
    /// <typeparam name="DbEntity"> Objeto de Base de datos Entity Framwework </typeparam>
    /// <typeparam name="TEntity"> Tabla del Entity Framework a la que se hará referencia</typeparam>
    /// <typeparam name="TModel"> Clase modelo </typeparam>
    public sealed class DAL<DbEntity, TEntity, TModel> : GenericDAL<DbEntity>, IRepository<TEntity, TModel>
        where DbEntity : DbContext, new()
        where TEntity : class, new()
        where TModel : class, new ()
    {
        public DAL()
        {
            this.dbEntity = new DbEntity();
        }

        /// <summary>
        /// Obener registros de la base de datos hacia una objeto tabla del Entity Framework
        /// </summary>
        /// <param name="filter">Expresión lambda [ Ej. ( qry => qry.[field] == [var] ) ]</param>
        /// <returns>Objeto tabla de Entity Framework</returns>

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter == null)
                return this.dbEntity.Set<TEntity>();
            return this.dbEntity.Set<TEntity>().Where(filter);
        }

        /// <summary>
        /// Obener registros de la base de datos hacia una objeto modelo
        /// </summary>
        /// <param name="filter">Expresión lambda [ Ej. ( qry => qry.[field] == [var] ) ]</param>
        /// <returns>Objeto modelo</returns>

        public IEnumerable<TModel> GetWithParse(Expression<Func<TEntity, bool>> filter = null)
        {
            IEnumerable<TEntity> qry;
            List<TModel> dta = new List<TModel>();

            qry = this.Get(filter);
            qry.ToList().ForEach(x =>
            {
                dta.Add(ModelFactory.getModel<TModel>(x, new TModel()));
            });

            return dta;
        }

        /// <summary>
        /// Obtener registro de la base de datos a partir del identifiacdor hacia una objeto tabla del Entity Framework
        /// </summary>
        /// <param name="filter">Expresión lambda [ Ej. ( qry => qry.[field] == [var] ) ]</param>
        /// <returns>Objeto tabla de Entity Framework</returns>
        public TEntity GetByID(Expression<Func<TEntity, bool>> filter = null)
        {
            return this.dbEntity.Set<TEntity>().FirstOrDefault(filter);
        }

        /// <summary>
        /// Obtener registro de la base de datos a partir del identifiacdor hacia una objeto modelo
        /// </summary>
        /// <param name="filter">Expresión lambda [ Ej. ( qry => qry.[field] == [var] ) ]</param>
        /// <returns>Objeto modelo</returns>
        public TModel GetByIDWithParse(Expression<Func<TEntity, bool>> filter = null)
        {
            TEntity qry = this.dbEntity.Set<TEntity>().FirstOrDefault(filter);
            return ModelFactory.getModel<TModel>(qry, new TModel());
        }

        /// <summary>
        /// Agregar registro a la base de datos a partir del objeto tabla del Entity Framework
        /// </summary>
        /// <param name="entity">Objeto tabla de Entity Framework</param>
        public void InsertFromEntity(TEntity entity)
        {
            this.dbEntity.Set<TEntity>().Add(entity);
        }

        /// <summary>
        /// Agregar registro a la base de datos a partir del objeto modelo
        /// </summary>
        /// <param name="model">Objeto modelo</param>
        public void InsertFromModel(TModel model)
        {
            this.dbEntity.Set<TEntity>().Add(EntityFactory.getEntity<TEntity>(model, new TEntity()));
        }

        /// <summary>
        /// Eliminar registro de la base de datos a partir de una expresión lambda
        /// </summary>
        /// <param name="filter">Expresión lambda [ Ej. ( qry => qry.[field] == [var] ) ]</param>
        public void Delete(Expression<Func<TEntity, bool>> filter = null)
        {
            this.GetByID(filter);
            this.dbEntity.Set<TEntity>().Remove(this.GetByID(filter));
        }

        /// <summary>
        /// Actualizar registro de la base de datos a partir del objeto tabla del Entity Framework
        /// </summary>
        /// <param name="entity">Objeto tabla de Entity Framework</param>
        public void Update(TEntity entity)
        {
            this.dbEntity.Set<TEntity>().Attach(entity);
            this.dbEntity.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        /// <summary>
        /// Actualizar registro de la base de datos a partir del objeto modelo
        /// </summary>
        /// <param name="model">Objeto modelo</param>
        public void UpdateFromModel(TModel model)
        {
            TEntity dta = EntityFactory.getEntity<TEntity>(model, new TEntity());
            this.dbEntity.Set<TEntity>().Attach(dta);
            this.dbEntity.Entry(dta).State = System.Data.Entity.EntityState.Modified;
        }

        /// <summary>
        /// Guardar cambios en la base de datos
        /// </summary>
        public void Save()
        {
            this.dbEntity.SaveChanges();
        }
    }
}