﻿using System.Text.Json.Serialization;

namespace KristofferStrube.Blazor.FileSystemAccess;

/// <summary>
/// <see href="https://wicg.github.io/file-system-access/#dictdef-filesystemcreatewritableoptions">FileSystemCreateWritableOptions browser specs</see>
/// </summary>
public class FileSystemCreateWritableOptions
{
    public FileSystemCreateWritableOptions(bool keepExistingData)
    {
        KeepExistingData = keepExistingData;
    }

    [JsonPropertyName("keepExistingData")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool KeepExistingData { get; set; }
}
