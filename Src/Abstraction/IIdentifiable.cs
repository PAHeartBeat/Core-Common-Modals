// --------------------------------------------------------------------------------------
// <copyright file="IIdentifiable.cs" company="iPAHeartBeat">
// Copyright (c) iPAHeartBeat. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------

using System;

namespace iPAHeartBeat.Core.Common.Abstraction;

/// <summary>
/// The Data type signature to provide Identifiable object with any kind of unique Data value.
/// </summary>
/// <typeparam name="TDataType">The Data Type of the unique field.</typeparam>
public interface IIdentifiable<out TDataType>
	where TDataType : IComparable, IComparable<TDataType> {
	/// <summary>
	/// Gets the Unique Identifier value.
	/// </summary>
	TDataType Id { get; }
}

/// <summary>
/// The Data type signature to provide Identifiable object with any kind of unique Data value where data type is string.
/// </summary>
public interface IIdentifiable : IIdentifiable<string> {
}
