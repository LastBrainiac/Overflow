using System.Text.Json.Serialization;

namespace SearchService.Models
{
    public class SearchQuestion
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        [JsonPropertyName("content")]
        public string? Content { get; set; }
        [JsonPropertyName("tags")]
        public List<string[]> Tags { get; set; } = new();
        [JsonPropertyName("createdAt")]
        public long CreatedAt { get; set; }
        [JsonPropertyName("hasAcceptedAnswer")]
        public bool HasAcceptedAnswer { get; set; }
        [JsonPropertyName("answerCount")]
        public int AnswerCount { get; set; }
    }
}
