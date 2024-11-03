import json
import random
import datetime
from faker import Faker

# Function to generate random job postings
def generate_job_postings(num_postings):
    fake = Faker()
    job_titles = ['Software Engineer', 'Data Scientist', 'DevOps Engineer', 'Cybersecurity Analyst', 'UI/UX Designer', 'Cloud Architect', 'IT Support Specialist', 'Project Manager', 'QA Engineer', 'Full Stack Developer']
    skills = ['Python', 'Java', 'JavaScript', 'C++', 'AWS', 'Azure', 'Docker', 'Kubernetes', 'SQL', 'NoSQL']

    job_postings = []
    postId = 1000
    for _ in range(num_postings):
        postId += 1
        posting = {
            "Id": str(postId),
            "JobTitle": random.choice(job_titles),
            "JobDescription": fake.paragraph(nb_sentences=3),
            "Salary": str(random.randint(50000, 150000)),
            "PostingDate": datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S.%f"),
            "ExpiryDate": (datetime.datetime.now() + datetime.timedelta(days=30)).strftime("%Y-%m-%d %H:%M:%S.%f"),
            "ExperienceRequired": str(random.randint(1, 5)),
            "QualificationRequired": str(f"{random.randint(2, 5)}+ years in {random.choice(skills)}" ),
            "ImageURL": "https://picsum.photos/200/300",
            "JobPostReviewStatus": str(random.randint(0, 1)),
            "IsActive": "true",
            "UserId": "3",
            "CompanyId": "1",
            "JobTypeId": str(random.randint(1, 3)),
            "Benefits": fake.paragraph(nb_sentences=5),
            "JobLocations": [
                {
                    "Id": str(postId),
                    "StressAddressDetail": f"{fake.street_address()}, {fake.city()}, {fake.state()}",
                    "JobPostId": str(postId),
                    "LocationId": str(random.randint(1, 6))
                }
            ],
            "JobSkillSets": [
                {
                    "Id": str(postId),
                    "SkillSetId": str(random.randint(1, 3)),
                    "JobPostId": str(postId)
                }
            ]
        }
        job_postings.append(posting)

    return job_postings

# Generate 40 job postings
job_data = generate_job_postings(40)

# Save to a JSON file
with open('job_postings.json', 'w') as f:
    json.dump(job_data, f, indent=4)