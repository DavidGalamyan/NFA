namespace NFA.Domain.Entity
{
	/// <summary>
	/// Контент - новость с сайта
	/// </summary>
	public class Content : BaseEntity
	{
		/// <summary>
		/// Ссылка
		/// </summary>
		public string LinkGuid { get; set; }

		/// <summary>
		/// Заголовок
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Описание
		/// </summary>
		public string Description { get; set; }
		
		/// <summary>
		/// Дата публикации 
		/// </summary>
		public DateTimeOffset? PubDate { get; set; }

		/// <summary>
		/// Раскодированное содержание записи
		/// </summary>
		public string ContentEncoded { get; set; }
	}
}
