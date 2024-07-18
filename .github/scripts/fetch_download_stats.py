import json
import os
import requests

# Replace 'ohhsodead' and 'arisen-studio' with the appropriate values
OWNER = 'ohhsodead'
REPO = 'arisen-studio'
TOKEN = os.getenv('GITHUB_TOKEN')

# GitHub API URL for repository releases
url = f'https://api.github.com/repos/{OWNER}/{REPO}/releases'

headers = {
    'Authorization': f'token {TOKEN}'
}

response = requests.get(url, headers=headers)
releases = response.json()

total_downloads = 0

# Sum up the download counts for all assets in all releases
for release in releases:
    for asset in release.get('assets', []):
        total_downloads += asset.get('download_count', 0)

# Prepare the JSON data
data = {
    'total_downloads': total_downloads
}

# Ensure the .github/stats/ directory exists
output_dir = '.github/stats'
os.makedirs(output_dir, exist_ok=True)

# Write the JSON data to a file
output_file = os.path.join(output_dir, 'download_stats.json')
with open(output_file, 'w') as f:
    json.dump(data, f, indent=4)

print(f'Total downloads: {total_downloads}')
print(f'Download stats saved to {output_file}')
