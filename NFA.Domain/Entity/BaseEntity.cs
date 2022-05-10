namespace NFA.Domain.Entity
{
	/// <summary>
	/// Базовая сущность
	/// </summary>
	public class BaseEntity
	{
		/// <summary>
		/// Id
		/// </summary>
		public Guid Id { get; set; }

		/// <summary>
		/// Время создания
		/// </summary>
		public DateTimeOffset TimeOfCreation { get; set; }

		/// <summary>
		/// Время обновления
		/// </summary>
		public DateTimeOffset TimeOfUpdate { get; set; }
	}
}
