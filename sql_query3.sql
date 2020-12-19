select distinct Name, Description
from skills
inner join jobskills on skills.id = jobskills.skillid
order by Name;