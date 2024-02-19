/* SPDX-License-Identifier: Apache-2.0
*
* The OpenSearch Contributors require contributions made to
* this file be licensed under the Apache-2.0 license or a
* compatible open source license.
*/

using System;
using System.Runtime.Serialization;
using OpenSearch.Net.Utf8Json;

namespace OpenSearch.Client;

/// <summary>
/// A neural query.
/// </summary>
[InterfaceDataContract]
[JsonFormatter(typeof(FieldNameQueryFormatter<NeuralQuery, INeuralQuery>))]
public interface INeuralQuery : IFieldNameQuery
{
	/// <summary>
	/// The text to search for.
	/// </summary>
	[DataMember(Name = "query_text")]
	string QueryText { get; set; }

	/// <summary>
	/// The id of the model to use with in the query.
	/// </summary>
	[DataMember(Name = "model_id")]
	string ModelId { get; set; }

	/// <summary>
	/// The number of neighbors the search of each graph will return.
	/// </summary>
	[DataMember(Name = "k")]
	int? K { get; set; }
}

[DataContract]
public class NeuralQuery : FieldNameQueryBase, INeuralQuery
{
	/// <inheritdoc />
	public string QueryText { get; set; }
	/// <inheritdoc />
	public string ModelId { get; set; }
	/// <inheritdoc />
	public int? K { get; set; }

	protected override bool Conditionless => IsConditionless(this);

	internal override void InternalWrapInContainer(IQueryContainer container) => container.Neural = this;

	internal static bool IsConditionless(INeuralQuery q) => string.IsNullOrEmpty(q.QueryText) || string.IsNullOrEmpty(q.ModelId) || q.K == null || q.K == 0 || q.Field.IsConditionless();
}

public class NeuralQueryDescriptor<T>
	: FieldNameQueryDescriptorBase<NeuralQueryDescriptor<T>, INeuralQuery, T>,
		INeuralQuery
	where T : class
{
	protected override bool Conditionless => NeuralQuery.IsConditionless(this);
	string INeuralQuery.QueryText { get; set; }
	string INeuralQuery.ModelId { get; set; }
	int? INeuralQuery.K { get; set; }

	/// <inheritdoc cref="INeuralQuery.QueryText" />
	public NeuralQueryDescriptor<T> QueryText(string queryText) => Assign(queryText, (a, t) => a.QueryText = t);

	/// <inheritdoc cref="INeuralQuery.ModelId" />
	public NeuralQueryDescriptor<T> Filter(string modelId) => Assign(modelId, (a, m) => a.ModelId = m);

	/// <inheritdoc cref="INeuralQuery.K" />
	public NeuralQueryDescriptor<T> K(int? k) => Assign(k, (a, v) => a.K = v);
}
