using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VkNet.Utils;

namespace VkNet.Abstractions.Utils;

/// <summary>
/// Rest Client
/// </summary>
public interface IRestClient : IDisposable
{
	/// <summary>
	/// Proxy
	/// </summary>
	[Obsolete("Use HttpClient to configure proxy. Documentation reference https://github.com/vknet/vk/wiki/Proxy-Configuration", true)]
	IWebProxy Proxy { get; set; }

	/// <summary>
	/// Таймаут на время выполнения запроса в секундах. Значение по умолчанию 300
	/// секунд.
	/// </summary>
	[Obsolete("Use HttpClient to configure timeout. Documentation reference https://github.com/vknet/vk/wiki/Proxy-Configuration", true)]
	TimeSpan Timeout { get; set; }

	/// <summary>
	/// Get request
	/// </summary>
	/// <param name="uri"> Uri </param>
	/// <param name="parameters"> </param>
	/// <param name="encoding"></param>
	/// <param name="token"></param>
	/// <returns> String result </returns>
	Task<HttpResponse<string>> GetAsync(Uri uri, IEnumerable<KeyValuePair<string, string>> parameters, Encoding encoding, CancellationToken token = default);

	/// <summary>
	/// POST запрос
	/// </summary>
	/// <param name="uri"> Uri </param>
	/// <param name="parameters"> Параметры </param>
	/// <param name="encoding"></param>
	/// <param name="headers"> Заголовки </param>
	/// <param name="token"></param>
	/// <returns> Строковый результат </returns>
	Task<HttpResponse<string>> PostAsync(Uri uri, IEnumerable<KeyValuePair<string, string>> parameters, Encoding encoding, IEnumerable<KeyValuePair<string, string>> headers = null, CancellationToken token = default);
}