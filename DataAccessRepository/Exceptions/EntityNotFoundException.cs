using System;

namespace DataAccessRepository.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(string entityName, int entityKey)
        {
            this.EntityName = entityName;
            this.EntityKey = entityKey;
            _message = string.Format("Entity of type '{0}' and key {1} not found in the current context.", entityName, EntityKey);
        }

        public string EntityName { get; set; }

        public int EntityKey { get; set; }

        private readonly string _message = null;
        public override string Message
        {
            get { return _message; }
        }
    }
}