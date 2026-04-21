// Copyright 2026 by PeopleWare n.v..
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace PPWCode.Util.Time.I;

/// <summary>
///     Represents a contract for providing time-related information.
/// </summary>
/// <typeparam name="T">
///     The type of the time value, which must be a value type implementing
///     <see cref="IComparable{T}" /> and <see cref="IEquatable{T}" />.
/// </typeparam>
public interface ITimeProvider<out T>
    where T : struct, IComparable<T>, IEquatable<T>
{
    /// <summary>
    ///     Gets the current time represented as an instance of type <typeparamref name="T" />.
    /// </summary>
    /// <remarks>
    ///     This property provides the current time according to the implementation logic of the
    ///     <see cref="ITimeProvider{T}" /> interface. The type <typeparamref name="T" /> must be a value type
    ///     implementing <see cref="IComparable{T}" /> and <see cref="IEquatable{T}" />.
    /// </remarks>
    T Now { get; }

    /// <summary>
    ///     Gets the current Coordinated Universal Time (UTC) as an instance of type <typeparamref name="T" />.
    /// </summary>
    /// <remarks>
    ///     This property provides the current UTC time according to the implementation logic of the
    ///     <see cref="ITimeProvider{T}" /> interface. The type <typeparamref name="T" /> must be a value type
    ///     that implements <see cref="IComparable{T}" /> and <see cref="IEquatable{T}" />.
    /// </remarks>
    T UtcNow { get; }
}
