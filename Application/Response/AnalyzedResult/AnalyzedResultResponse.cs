using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response.AnalyzedResult
{
    public class AnalyzedResultResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("processing_time")]
        public double ProcessingTime { get; set; }

        [JsonProperty("device_used")]
        public string DeviceUsed { get; set; }

        [JsonProperty("match_details")]
        public MatchDetails MatchDetails { get; set; }
    }

    public class MatchDetails
    {
        [JsonProperty("job_id")]
        public int JobId { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("candidate_name")]
        public string CandidateName { get; set; }

        [JsonProperty("candidate_email")]
        public string CandidateEmail { get; set; }

        [JsonProperty("scores")]
        public Scores Scores { get; set; }

        [JsonProperty("skill_analysis")]
        public SkillAnalysis SkillAnalysis { get; set; }

        [JsonProperty("experience_analysis")]
        public ExperienceAnalysis ExperienceAnalysis { get; set; }

        [JsonProperty("recommendation")]
        public Recommendation Recommendation { get; set; }
    }

    public class Scores
    {
        [JsonProperty("overall_match")]
        public double OverallMatch { get; set; }

        [JsonProperty("skill_match")]
        public double SkillMatch { get; set; }

        [JsonProperty("experience_match")]
        public double ExperienceMatch { get; set; }

        [JsonProperty("content_similarity")]
        public double ContentSimilarity { get; set; }
    }

    public class SkillAnalysis
    {
        [JsonProperty("matching_skills")]
        public List<string> MatchingSkills { get; set; }

        [JsonProperty("missing_skills")]
        public List<string> MissingSkills { get; set; }

        [JsonProperty("additional_skills")]
        public List<string> AdditionalSkills { get; set; }
    }

    public class ExperienceAnalysis
    {
        [JsonProperty("required_years")]
        public double RequiredYears { get; set; }

        [JsonProperty("candidate_years")]
        public double CandidateYears { get; set; }

        [JsonProperty("meets_requirement")]
        public bool MeetsRequirement { get; set; }
    }

    public class Recommendation
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }
    }

}
