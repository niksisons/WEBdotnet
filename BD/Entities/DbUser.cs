namespace DB.Entities
{
    public class DbUser
    {
        /// <summary>
        /// Идентификационный номер
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string? MiddleName { get; set; }

        /// <summary>
        /// Почта
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTimeOffset? Birthday { get; set; } = null;

        /// <summary>
        /// Пол
        /// </summary>
        public GenderType Gender { get; set; }

        /// <summary>
        /// Страна
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Город
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Дата-время создания сущности
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

        /// <summary>
        /// Дата-время удаления сущности
        /// </summary>
        public DateTimeOffset? DeletedAt { get; set; } = null;

        /// <summary>
        /// Идентификационный номер роли пользователя
        /// </summary>
       // public int RoleId { get; set; } = 1;

        /// <summary>
        /// Роль пользователя
        /// </summary>
       // public DbRole Role { get; set; }
    }

    public enum GenderType : byte
    {
        Default = 0,

        Man = 1,

        Woman = 2
    }
}
