using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
class IPLCensorship
{
public static void Print()
{
string jsonInputPath = &quot;ipl_data.json&quot;;
string csvInputPath = &quot;ipl_data.csv&quot;;
string jsonOutputPath = &quot;ipl_data_censored.json&quot;;
string csvOutputPath = &quot;ipl_data_censored.csv&quot;;
CreateSampleFiles(jsonInputPath, csvInputPath);
// Process JSON
if (File.Exists(jsonInputPath))

{
var matches =
JsonConvert.DeserializeObject&lt;List&lt;Match&gt;&gt;(File.ReadAllText(jsonInputPath));
matches.ForEach(CensorMatch);
File.WriteAllText(jsonOutputPath,
JsonConvert.SerializeObject(matches, Formatting.Indented));
Console.WriteLine($&quot;Censored JSON saved: {jsonOutputPath}&quot;);
}
// Process CSV
if (File.Exists(csvInputPath))
{
var lines = File.ReadAllLines(csvInputPath).ToList();
for (int i = 1; i &lt; lines.Count; i++) // Skip header row
{
var columns = lines[i].Split(&#39;,&#39;);
columns[1] = CensorTeamName(columns[1]); // team1
columns[2] = CensorTeamName(columns[2]); // team2
columns[5] = CensorTeamName(columns[5]); // winner
columns[6] = &quot;REDACTED&quot;; // player_of_match
lines[i] = string.Join(&quot;,&quot;, columns);
}
File.WriteAllLines(csvOutputPath, lines);
Console.WriteLine($&quot;Censored CSV saved: {csvOutputPath}&quot;);
}
}
// Function to create sample JSON and CSV files if they do not exist
static void CreateSampleFiles(string jsonPath, string csvPath)
{
if (!File.Exists(jsonPath))
{
var sampleJson = new List&lt;Match&gt;
{
new Match { match_id = 101, team1 = &quot;Mumbai Indians&quot;, team2
= &quot;Chennai Super Kings&quot;, score = new Dictionary&lt;string, int&gt; { {&quot;Mumbai
Indians&quot;, 178}, {&quot;Chennai Super Kings&quot;, 182} }, winner = &quot;Chennai Super
Kings&quot;, player_of_match = &quot;MS Dhoni&quot; },
new Match { match_id = 102, team1 = &quot;Royal Challengers
Bangalore&quot;, team2 = &quot;Delhi Capitals&quot;, score = new Dictionary&lt;string, int&gt; {
{&quot;Royal Challengers Bangalore&quot;, 200}, {&quot;Delhi Capitals&quot;, 190} }, winner =
&quot;Royal Challengers Bangalore&quot;, player_of_match = &quot;Virat Kohli&quot; }
};
File.WriteAllText(jsonPath,
JsonConvert.SerializeObject(sampleJson, Formatting.Indented));
Console.WriteLine($&quot;Sample JSON file created: {jsonPath}&quot;);
}

if (!File.Exists(csvPath))
{
var sampleCsv =
&quot;match_id,team1,team2,score_team1,score_team2,winner,player_of_match\n&quot; +
&quot;101,Mumbai Indians,Chennai Super
Kings,178,182,Chennai Super Kings,MS Dhoni\n&quot; +
&quot;102,Royal Challengers Bangalore,Delhi
Capitals,200,190,Royal Challengers Bangalore,Virat Kohli&quot;;
File.WriteAllText(csvPath, sampleCsv);
Console.WriteLine($&quot;Sample CSV file created: {csvPath}&quot;);
}
}
// Match class for JSON parsing
class Match
{
public int match_id { get; set; }
public string team1 { get; set; }
public string team2 { get; set; }
public Dictionary&lt;string, int&gt; score { get; set; }
public string winner { get; set; }
public string player_of_match { get; set; }
}
// Censor match details
static void CensorMatch(Match match)
{
match.team1 = CensorTeamName(match.team1);
match.team2 = CensorTeamName(match.team2);
match.winner = CensorTeamName(match.winner);
match.player_of_match = &quot;REDACTED&quot;;
var censoredScore = new Dictionary&lt;string, int&gt;();
foreach (var entry in match.score)
{
censoredScore[CensorTeamName(entry.Key)] = entry.Value;
}
match.score = censoredScore;
}
// Function to censor team names
static string CensorTeamName(string teamName)
{
var words = teamName.Split(&#39; &#39;);
if (words.Length &gt; 1)
words[1] = &quot;***&quot;;

return string.Join(&quot; &quot;, words);
}
