import json
import os
import requests

# Replace 'ohhsodead' and 'arisen-studio' with the appropriate values
OWNER = 'ohhsodead'
REPO = 'arisen-studio'
TOKEN = os.getenv('GITHUB_TOKEN')

# GitHub API URL for repository releases
releases_url = f'https://api.github.com/repos/{OWNER}/{REPO}/releases'
mod_count_url = 'https://raw.githubusercontent.com/ohhsodead/arisen-studio-database/main/badges/mod_count_badge.json'
package_count_url = 'https://raw.githubusercontent.com/ohhsodead/arisen-studio-database/main/badges/package_count_badge.json'

headers = {
    'Authorization': f'token {TOKEN}'
}

# Fetch release data
response = requests.get(releases_url, headers=headers)
releases = response.json()

total_downloads = 0

# Sum up the download counts for all assets in all releases
for release in releases:
    for asset in release.get('assets', []):
        total_downloads += asset.get('download_count', 0)

# Fetch mod count
response = requests.get(mod_count_url)
mod_count = response.json().get('message', 0)

# Fetch package count
response = requests.get(package_count_url)
package_count = response.json().get('message', 0)

# Calculate total mods
total_mods = int(mod_count) + int(package_count)

# Prepare the JSON data
data = {
    'total_downloads': total_downloads,
    'total_mods': total_mods
}

# Ensure the .github/stats/ directory exists
output_dir = '.github/stats'
os.makedirs(output_dir, exist_ok=True)

# Write the JSON data to a file
output_file = os.path.join(output_dir, 'stats.json')
with open(output_file, 'w') as f:
    json.dump(data, f, indent=4)

print(f'Total downloads: {total_downloads}')
print(f'Total mods: {total_mods}')
print(f'Download stats saved to {output_file}')
