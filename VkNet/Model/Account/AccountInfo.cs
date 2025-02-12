using Newtonsoft.Json;
using System;

namespace VkNet.Model;

/// <summary>
/// Хранит информацию о текущем аккаунте. Подробнее:
/// https://vk.com/dev/account.getInfo
/// </summary>
[Serializable]
public class AccountInfo
{
	/// <summary>
	/// Строковой код страны, определенный по IP адресу, с которого сделан запрос.
	/// </summary>
	[JsonProperty("country")]
	public string Country { get; set; }

	/// <summary>
	/// Пользователь установил в настройках аккаунта "Всегда использовать безопасное
	/// соединение"
	/// </summary>
	[JsonProperty("https_required")]
	public bool? HttpsRequired { get; set; }

	/// <summary>
	/// Битовая маска, отвечающая за прохождение обучения использованию приложения.
	/// </summary>
	[JsonProperty("intro")]
	public int? Intro { get; set; }

	/// <summary>
	/// Числовой идентификатор текущего языка пользователя.
	/// </summary>
	[JsonProperty("language")]
	public int? Language { get; set; }

	[JsonProperty("lang")]
	private int? Lang
	{
		get => Language;
		set => Language = value;
	}

	/// <summary>
	/// 1 - на стене пользователя по-умолчанию должны отображаться только собственные
	/// записи.
	/// Соответствует настройке на сайте "Показывать только мои записи", 0 - на стене
	/// пользователя должны отображаться все
	/// записи.
	/// </summary>
	[JsonProperty("own_posts_default")]
	public bool? OwnPostsDefault { get; set; }

	/// <summary>
	/// 1 - пользователь отключил комментирование записей на стене, 0 - комментирование
	/// записей разрешено.
	/// </summary>
	[JsonProperty("no_wall_replies")]
	public bool? NoWallReplies { get; set; }

	/// <summary>
	/// Информация о том, включена ли двухфакторная аутентификация для аккаунта. 1 —
	/// включена, 0 — не включена.
	/// </summary>
	[JsonProperty("two_factor_required")]
	public bool? TwoFactorRequired { get; set; }
}