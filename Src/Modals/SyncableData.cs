// --------------------------------------------------------------------------------------
// <copyright file="SyncableData.cs" company="iPAHeartBeat">
// Copyright (c) iPAHeartBeat. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------

using System;

using iPAHeartBeat.Core.Extensions;

namespace iPAHeartBeat.Core.Common.Modals;

/// <summary>
/// Data Structure to Handle and validate data to sync with server.
/// </summary>
public abstract class SyncableData {
	/// <summary>
	/// The epoch time value in sec.
	/// </summary>
	public long lastModifiedTime;

	/// <summary>
	/// Initializes a new instance of the <see cref="SyncableData"/> class.
	/// </summary>
	protected SyncableData() {
		this.lastModifiedTime = 0;
	}

	/// <summary>
	/// Convert epoch time to C# Date Time.
	/// </summary>
	/// <returns>Date Time as UTC Value.</returns>
	public DateTime GetLastModifiedTime() =>
		this.lastModifiedTime.GetDateFromEpoch();
}
