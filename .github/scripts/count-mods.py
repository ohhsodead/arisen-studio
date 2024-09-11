import json
import os
import requests

def fetch_json(url):
    response = requests.get(url)
    if response.status_code == 200:
        try:
            # Decode using 'utf-8-sig' to handle BOM if present
            return json.loads(response.content.decode('utf-8-sig'))
        except json.JSONDecodeError as e:
            print(f"JSON decode error for {url}: {e}")
            return None
    else:
        print(f"Failed to fetch JSON from {url}. Status code: {response.status_code}")
        return None

def count_mods_in_specific_files(urls):
    mod_count = 0
    for url in urls:
        data = fetch_json(url)
        if data:
            mod_count += len(data.get("Library", []))
        else:
            print(f"Failed to load JSON from {url}")
    return mod_count

def count_saves_in_specific_files(urls):
    save_count = 0
    for url in urls:
        data = fetch_json(url)
        if data:
            save_count += len(data.get("GameSaves", []))
        else:
            print(f"Failed to load JSON from {url}")
    return save_count

if __name__ == "__main__":
    mod_urls = [
        "https://db.arisen.studio/data/ps3/game-mods.json",
        "https://db.arisen.studio/data/ps3/homebrew.json",
        "https://db.arisen.studio/data/ps3/resources.json",
        "https://db.arisen.studio/data/ps4/homebrew.json",
        "https://db.arisen.studio/data/xbox360/game-mods.json",
        "https://db.arisen.studio/data/xbox360/homebrew.json",
        "https://db.arisen.studio/data/xbox360/trainers.json"
    ]
    
    save_urls = [
        "https://db.arisen.studio/data/game-saves.json"
    ]
    
    total_mods = count_mods_in_specific_files(mod_urls)
    total_saves = count_saves_in_specific_files(save_urls)
    
    total_count = total_mods + total_saves
    
    badge_data = {
        "schemaVersion": 1,
        "label": "mods",
        "message": str(total_count),
        "color": "brightgreen"
    }
    
    os.makedirs('.github/badges', exist_ok=True)
    badge_path = '.github/badges/mods-badge.json'
    with open(badge_path, 'w') as f:
        json.dump(badge_data, f)
    
    print(f"Badge data written to {badge_path}")
