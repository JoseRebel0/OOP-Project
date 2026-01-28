/*
*	<copyright file="Data.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>joser</author>
*   <date>03/11/2025 21:32:51</date>
*	<description></description>
**/

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using Trabalho_POO.Controller;
using Trabalho_POO.View;

namespace Trabalho_POO.Model
{
    [Serializable]
    public class Data
    {

        #region Methods

        /// <summary>
        /// Save data
        /// </summary>
        public bool Save(string fileName)
        {
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(fs, this);
                fs.Close();

                return true;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Read data
        /// </summary>
        public static Data Load(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return null;
            }

            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();

                bf.Deserialize(fs);
                fs.Close();

                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
        #endregion
    }
}
