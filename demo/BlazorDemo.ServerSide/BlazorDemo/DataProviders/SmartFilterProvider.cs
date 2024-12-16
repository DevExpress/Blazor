using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Numerics.Tensors;
using System.Threading.Tasks;
using Azure.AI.OpenAI;
using Microsoft.Extensions.AI;

namespace BlazorDemo.DataProviders;
public class SmartFilterProvider {
    readonly IEmbeddingGenerator<string, Embedding<float>> Embedder;
    readonly static ConcurrentDictionary<string, Embedding<float>> cache = new(StringComparer.OrdinalIgnoreCase);
    public SmartFilterProvider(AzureOpenAIClient openAIClient) {
        Embedder = openAIClient.AsEmbeddingGenerator("text-embedding-3-small");
    }

    public async Task FillCacheAsync(IEnumerable<string> words) {
        try {
            var nonCachedWords = words.Where(x => !cache.ContainsKey(x)).ToArray();
            if(!nonCachedWords.Any())
                return;

            var embeddings = await Embedder.GenerateAsync(nonCachedWords);
            foreach(var (word, embedding) in nonCachedWords.Zip(embeddings)) {
                cache[word] = embedding;
            }
        } catch {

        }
    }

    public bool IsSimilarTo(string filter, string text, float threshold = 0.75f) {
        var eFilter = cache[filter];
        var eText = cache[text];
        var cosineSimilarity = TensorPrimitives.CosineSimilarity(eText.Vector.Span, eFilter.Vector.Span);
        return cosineSimilarity > threshold;
    }
}

