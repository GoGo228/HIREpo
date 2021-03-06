﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ISharpConvertor.DAL.Abstract
{
    public interface IBaseRepository<T> : IDisposable where T : class
    {

       /// <summary>
        /// Method for insert data at DB 
        /// </summary>
        /// <param name="item">Entity object</param>
        void Insert(T item);

        /// <summary>
        /// Method for update data 
        /// </summary>
        /// <param name="item">Entity object</param>
        void Update(T item);

        /// <summary>
        /// Select method select all data
        /// </summary>
        /// <returns>Collection of all from current table</returns>
        IEnumerable<T> Fetch();

        /// <summary>
        /// Get selected items by predicate
        /// </summary>
        /// <param name="predecate">must return bool value</param>
        /// <returns>Collection of items  by predicate</returns>
        IEnumerable<T> FetchBy(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Paging method
        /// </summary>
        /// <param name="startIndex">From what index of record need start selection </param>
        /// <param name="count">count of records need get</param>
        /// <returns>Collection of records</returns>
        T Find(string id);
        IEnumerable<T> PaggingFetch(int startIndex, int count);

        /// <summary>
        /// Paging method
        /// </summary>
        /// <param name="startIndex">From what index of record need start selection </param>
        /// <param name="count">count of records need get</param>
        /// <param name="predicate">bool expresion</param>
        /// <returns>Collection of records</returns>
        IEnumerable<T> PaggingFetchBy(Expression<Func<T, bool>> predicate, int startIndex, int count);

        /// <summary>
        /// Paging method for get count of records
        /// </summary>
        /// <returns>Count records at table</returns>
        int GetCount();

        /// <summary>
        /// Get recoord by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Reccord from current entity by id</returns>
        T GetById(int id);

        /// <summary>
        /// Remove item by id
        /// </summary>
        /// <param name="id">Unique id of entity</param>
        void Remove(T item);
        /// <summary>
        /// Save the dbContext method
        /// </summary>
        void SaveContext();


    }
    }

