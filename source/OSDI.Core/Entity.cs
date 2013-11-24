namespace OSDI
{
    using System;

    public class Entity
    {
        /// <summary>
        /// The date the entity was created.
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; }


        /// <summary>
        /// The date the entity was modified.
        /// </summary>
        public DateTimeOffset ModifiedAt { get; set; }
    }
}