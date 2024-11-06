using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response.AnalyzedResult
{
    public class AnalyzedResultResponse
    {
        public bool Success { get; set; }
        public double ProcessingTime { get; set; }
        public string DeviceUsed { get; set; }
        public MatchDetails MatchDetails { get; set; }
    }
    public class MatchDetails
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public string CandidateName { get; set; }
        public string CandidateEmail { get; set; }
        public Scores Scores { get; set; }
        public SkillAnalysis SkillAnalysis { get; set; }
        public ExperienceAnalysis ExperienceAnalysis { get; set; }
        public Recommendation Recommendation { get; set; }
    }

    public class Scores
    {
        public double OverallMatch { get; set; }
        public double SkillMatch { get; set; }
        public double ExperienceMatch { get; set; }
        public double ContentSimilarity { get; set; }
    }

    public class SkillAnalysis
    {
        public List<string> MatchingSkills { get; set; }
        public List<string> MissingSkills { get; set; }
        public List<string> AdditionalSkills { get; set; }
    }

    public class ExperienceAnalysis
    {
        public double RequiredYears { get; set; }
        public double CandidateYears { get; set; }
        public bool MeetsRequirement { get; set; }
    }

    public class Recommendation
    {
        public string Category { get; set; }
        public string Action { get; set; }
    }
}
