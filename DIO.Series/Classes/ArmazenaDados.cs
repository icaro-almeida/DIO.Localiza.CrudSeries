using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DIO.Series
{
    public class ArmazenaDados
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static void VerificaECriaDiretorio(string folderPath)
        {
            try
            {
                System.IO.Directory.CreateDirectory(folderPath);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        /// <summary>Serializa e salva uma List num arquivo</summary>
        public static void SaveList<T>(string fileName, List<T> list)
        {
            // Gain code access to the file that we are going
            // to write to
            try
            {
                // Create a FileStream that will write data to file.
                using (var stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(stream, list);
                    logger.Info("Arquivo salvo: " + fileName);
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        /// <summary>Desserializa e carrega uma List a partir de um arquivo</summary>
        public static List<T> LoadList<T>(string fileName)
        {
            var list = new List<T>();
            // Check if we had previously Save information of our friends
            // previously
            if (File.Exists(fileName))
            {
                try
                {
                    // Create a FileStream will gain read access to the
                    // data file.
                    using (var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                    {
                        var formatter = new BinaryFormatter();
                        list = (List<T>)formatter.Deserialize(stream);
                        logger.Info("Arquivo carregado: " + fileName);
                    }
                }
                catch (Exception ex)
                {
                    logger.Error(ex);
                }

                return list;
            }
            else
            {
                return null;
            }
        }

    }
}