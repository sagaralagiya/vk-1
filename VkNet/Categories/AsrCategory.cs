﻿using VkNet.Abstractions;
using VkNet.Enums.StringEnums;
using VkNet.Model.Results.Asr;
using VkNet.Utils;

namespace VkNet.Categories;

/// <inheritdoc />
public partial class AsrCategory : IAsrCategory
{
	/// <summary>
	/// API.
	/// </summary>
	private readonly IVkApiInvoke _vk;

	/// <summary>
	/// api vk.com
	/// </summary>
	/// <param name="vk"> API. </param>
	public AsrCategory(IVkApiInvoke vk) => _vk = vk;

	/// <inheritdoc />
	public AudioRecordingTask CheckStatus(string taskId) => _vk.Call<AudioRecordingTask>("asr.checkStatus",
		new()
		{
			{
				"task_id", taskId
			}
		});

	/// <inheritdoc />
	public UploadUrlResult GetUploadUrl() => _vk.Call<UploadUrlResult>("asr.getUploadUrl",
		VkParameters.Empty);

	/// <inheritdoc />
	public TaskIdResult Process(string audio, AsrProcessModel model) => _vk.Call<TaskIdResult>("asr.process",
		new()
		{
			{
				"audio", audio
			},
			{
				"model", model
			}
		});
}