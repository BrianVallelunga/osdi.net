namespace OSDI
{
    using System;

    public class Entity
    {
        public Entity()
        {
            this.CreatedAt = DateTime.UtcNow;
            this.ModifiedAt = this.CreatedAt;
        }

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