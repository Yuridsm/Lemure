using System;
using System.Collections.Generic;

namespace Lemure.Generics.GenericIdentifier
{

    public interface IEntity : IEquatable<IEntity>
    {
        public int? Id { get; }
    }

    #region Entities
    public class Document : IEntity
    {
        public int? Id { get; } = new Random().Next(10000, 99999);

        public bool Equals(IEntity other) => throw new NotImplementedException();
    }

    public class Sheet : IEntity
    {
        public int? Id { get; } = 654321;

        public bool Equals(IEntity other) => throw new NotImplementedException();
    }
    #endregion

    public interface IServices<T> where T : IEntity
    {
        void RunSmt(T entity);
    }

    #region Services
    public class LegalOneServices<T> : IServices<T> where T : IEntity
    {
        public void RunSmt(T entity)
        {
            Console.WriteLine($"Legal One - [{entity.Id}] : Running something");
        }
    }

    public class BMGServices<T> : IServices<T> where T : IEntity
    {
        public void RunSmt(T entity)
        {
            Console.WriteLine($"BMG - [{entity.Id}] : Running something");
        }
    }
    #endregion

    #region Factories
    public static class EntityFactory
    {
        public static Document CreateDocument()
        {
            return new Document();
        }

        public static Sheet CreateSheet()
        {
            return new Sheet();
        }
    }

    public static class BMGFactory
    {
        private static BMGServices<Document> _documentService;
        private static BMGServices<Sheet> _sheetService;

        public static IServices<Document> CreateDocumentService()
        {
            _documentService = new BMGServices<Document>();
            return _documentService;
        }

        public static IServices<Sheet> CreateSheetService()
        {
            _sheetService = new BMGServices<Sheet>();
            return _sheetService;
        }
    }
    #endregion

    #region Clients
    public class Client
    {
        public void Run()
        {
            // Quero dois serviços BMG e Legal One ambos executando para Document e Sheet

            // Entities
            List<Document> entities = new List<Document>()
            {
                EntityFactory.CreateDocument(),
                EntityFactory.CreateDocument(),
                EntityFactory.CreateDocument(),
                EntityFactory.CreateDocument(),
                EntityFactory.CreateDocument(),
                EntityFactory.CreateDocument(),
                EntityFactory.CreateDocument(),
                EntityFactory.CreateDocument(),
                EntityFactory.CreateDocument()
            };

            // BMG and Legal One Service
            var bmgService = BMGFactory.CreateDocumentService();
            foreach(var entity in entities)
            {
                bmgService.RunSmt(entity);
            }
        }
    }
    #endregion
}