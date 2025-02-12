﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using VkNet.Utils;

namespace VkNet.Enums.SafetyEnums;

/// <summary>
/// Аналог enum, типобезопасен.
/// </summary>
/// <typeparam name="TFilter"> Непосредственно наследник </typeparam>
[Serializable]
[SuppressMessage("ReSharper", "StaticMemberInGenericType")]
public abstract class SafetyEnum<TFilter>
	: IEqualityComparer<SafetyEnum<TFilter>>, IEquatable<SafetyEnum<TFilter>>
	where TFilter : SafetyEnum<TFilter>, new()
{
	/// <summary>
	/// Значение
	/// </summary>
	private string _value;

	/// <inheritdoc />
	public bool Equals(SafetyEnum<TFilter> x, SafetyEnum<TFilter> y) => x == y;

	/// <inheritdoc />
	public bool Equals(SafetyEnum<TFilter> other) => Equals(this, other);

	/// <inheritdoc />
	public override bool Equals(object obj) => this == (SafetyEnum<TFilter>) obj;

	/// <summary>
	/// Регистрирует возможное значение.
	/// </summary>
	/// <param name="value"> Значение. </param>
	/// <returns> </returns>
	/// <exception cref="System.ArgumentException">
	/// Mask must be a power of 2 (i.e.
	/// only one bit must be equal to 1);mask
	/// </exception>
	public static TFilter RegisterPossibleValue(string value) => new()
	{
		_value = value
	};

	/// <summary>
	/// Преобразовать в строку.
	/// </summary>
	public override string ToString() => _value;

	/// <summary>
	/// Реализация оператора ==.
	/// </summary>
	/// <param name="left"> Левая часть. </param>
	/// <param name="right"> Правая часть. </param>
	/// <returns>
	/// Результат.
	/// </returns>
	public static bool operator ==(SafetyEnum<TFilter> left, SafetyEnum<TFilter> right)
	{
		if (ReferenceEquals(right, left))
		{
			return true;
		}

		if (left is null || right is null)
		{
			return false;
		}

		return left._value == right._value;
	}

	/// <summary>
	/// Реализация оператора !=.
	/// </summary>
	/// <param name="left"> Левая часть. </param>
	/// <param name="right"> Правая часть. </param>
	/// <returns>
	/// Результат.
	/// </returns>
	public static bool operator !=(SafetyEnum<TFilter> left, SafetyEnum<TFilter> right) => !(left == right);

	/// <summary>
	/// Разобрать из json.
	/// </summary>
	/// <param name="response"> Ответ сервера. </param>
	/// <returns> Объект перечисления типа TFilter - Непосредственно наследник </returns>
	public static TFilter FromJson(VkResponse response)
	{
		var value = response.ToString();

		return FromJsonString(response: value);
	}

	/// <summary>
	/// Разобрать из json.
	/// </summary>
	/// <param name="response"> Ответ сервера. </param>
	/// <returns> Объект перечисления типа TFilter - Непосредственно наследник </returns>
	public static TFilter FromJsonString(string response)
	{
		if (string.IsNullOrWhiteSpace(value: response))
		{
			return null;
		}

		var result = new TFilter
		{
			_value = response
		};

		Activator.CreateInstance(type: result.GetType());

		return result;
	}

	/// <inheritdoc />
	public int GetHashCode(SafetyEnum<TFilter> obj) => obj._value.GetHashCode();

	/// <inheritdoc />
	public override int GetHashCode() => GetHashCode(obj: this);
}