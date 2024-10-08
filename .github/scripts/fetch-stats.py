import json
import os
import requests

TOKEN = os.getenv('GITHUB_TOKEN')

# GitHub API URL for repository releases
releases_url = f'https://api.github.com/repos/ohhsodead/arisen-studio/releases'
mod_count_url = 'https://raw.githubusercontent.com/ohhsodead/arisen-studio/main/.github/badges/mods-badge.json'
package_count_url = 'https://raw.githubusercontent.com/ohhsodead/arisen-studio/main/.github/badges/pkgs-badge.json'

headers = {
    'Authorization': f'token {TOKEN}'
}

# Fetch release data
response = requests.get(releases_url, headers=headers)
try:
    releases = response.json()
except requests.exceptions.JSONDecodeError:
    print(f"Error: Unable to parse JSON from releases response: {response.text}")
    releases = []

total_downloads = 0

# Sum up the download counts for all assets in all releases
for release in releases:
    for asset in release.get('assets', []):
        total_downloads += asset.get('download_count', 0)

# Function to fetch JSON safely
def fetch_json(url):
    response = requests.get(url)
    try:
        return response.json()
    except requests.exceptions.JSONDecodeError:
        print(f"Error: Unable to parse JSON from {url}: {response.text}")
        return {}

# Fetch mod count
mod_data = fetch_json(mod_count_url)
mod_count = mod_data.get('message', 0)

# Fetch package count
package_data = fetch_json(package_count_url)
package_count = package_data.get('message', 0)

# Calculate total mods
try:
    total_mods = int(mod_count) + int(package_count)
except ValueError:
    print("Error: Mod or package count is not a valid integer.")
    total_mods = 0

# Prepare the JSON data
data = {
    'totalDownloads': total_downloads,
    'totalMods': total_mods
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
