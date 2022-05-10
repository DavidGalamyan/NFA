namespace NFA.Domain.Entity
{
	/// <summary>
	/// Сущность сайта, с которого необходимо сохранять новости
	/// </summary>
	public class Site : BaseEntity
	{
		/// <summary>
		/// Ссылка
		/// </summary>
		public string Link { get; set; }

		/// <summary>
		/// Заголовок
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Описание
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Связь контента с сайтами
		/// </summary>
		public ICollection<Content> Contents { get; set; }
	}
}
