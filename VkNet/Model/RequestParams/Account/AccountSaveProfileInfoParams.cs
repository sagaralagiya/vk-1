﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkNet.Enums;

namespace VkNet.Model.RequestParams;

/// <summary>
/// Параметры метода account.saveProfileInfo
/// </summary>
[Serializable]
public class AccountSaveProfileInfoParams
{
	/// <summary>
	/// Имя пользователя. строка.
	/// </summary>
	[JsonProperty("first_name")]
	public string FirstName { get; set; }

	/// <summary>
	/// Фамилия пользователя. строка.
	/// </summary>
	[JsonProperty("last_name")]
	public string LastName { get; set; }

	/// <summary>
	/// Девичья фамилия пользователя (только для женского пола). строка.
	/// </summary>
	[JsonProperty("maiden_name")]
	public string MaidenName { get; set; }

	/// <summary>
	/// Короткое имя страницы. строка.
	/// </summary>
	[JsonProperty("screen_name")]
	public string ScreenName { get; set; }

	/// <summary>
	/// Пол пользователя. Возможные значения:
	/// 1 — женский;
	/// 2 — мужской.
	/// положительное число.
	/// </summary>
	[JsonProperty("sex")]
	public Sex? Sex { get; set; }

	/// <summary>
	/// Семейное положение пользователя. Возможные значения:
	/// 1 — не женат/не замужем;
	/// 2 — есть друг/есть подруга;
	/// 3 — помолвлен/помолвлена;
	/// 4 — женат/замужем;
	/// 5 — всё сложно;
	/// 6 — в активном поиске;
	/// 7 — влюблён/влюблена;
	/// 0 — не указано.
	/// положительное число.
	/// </summary>
	[JsonProperty("relation")]
	public RelationType? Relation { get; set; }

	/// <summary>
	/// Идентификатор пользователя, с которым связано семейное положение. положительное
	/// число.
	/// </summary>
	[JsonProperty("relation_partner")]
	public User RelationPartner { get; set; }

	/// <summary>
	/// Дата рождения пользователя в формате DD.MM.YYYY, например "15.11.1984". строка.
	/// </summary>
	[JsonProperty("bdate")]
	public string BirthDate { get; set; }

	/// <summary>
	/// Видимость даты рождения. Возможные значения:
	/// 1 — показывать дату рождения;
	/// 2 — показывать только месяц и день;
	/// 0 — не показывать дату рождения.
	/// положительное число.
	/// </summary>
	[JsonProperty("bdate_visibility")]
	public BirthdayVisibility? BirthdayVisibility { get; set; }

	/// <summary>
	/// Родной город пользователя. строка.
	/// </summary>
	[JsonProperty("home_town")]
	public string HomeTown { get; set; }

	/// <summary>
	/// Идентификатор страны пользователя. положительное число.
	/// </summary>
	[JsonProperty("country")]
	public Country Country { get; set; }

	/// <summary>
	/// Идентификатор города пользователя. положительное число.
	/// </summary>
	[JsonProperty("city")]
	public City City { get; set; }

	/// <summary>
	/// Статус пользователя, который также может быть изменен методом status.set
	/// строка.
	/// </summary>
	[JsonProperty("status")]
	public string Status { get; set; }

	/// <summary>
	/// Телефон.
	/// </summary>
	/// <remarks>
	/// Обнаружено опытным путем.
	/// </remarks>
	[JsonProperty("phone")]
	public string Phone { get; set; }

	/// <summary>
	/// Передается 1, если пользователь, указанный в RelationPartner, не подтвердил отношения.
	/// </summary>
	[JsonProperty("relation_pending")]
	public int RelationPending { get; set; }

	/// <summary>
	/// Список объектов пользователей, которые указали, что состоят в отношениях с данным пользователем (если есть).
	/// </summary>
	[JsonProperty("relation_requests")]
	public List<User> RelationRequests { get; set; }

	/// <summary>
	/// Информация о заявке на смену имени, если она была подана
	/// </summary>
	[JsonProperty("name_request")]
	public NameRequest NameRequest { get; set; }

	/// <summary>
	/// Идентификатор заявки на смену имени, которую необходимо отменить.
	/// Если передан этот параметр, все остальные параметры игнорируются.
	/// </summary>
	[JsonProperty("cancel_request_id")]
	public ulong CancelRequestId { get; set; }
}