import os

def count_solved_problems():
    problems_dir = 'Problems'
    if not os.path.exists(problems_dir):
        return 0
    return sum(os.path.isdir(os.path.join(problems_dir, name)) for name in os.listdir(problems_dir))

def update_readme(count):
    readme_path = 'README.md'
    with open(readme_path, 'r', encoding='utf-8') as file:
        lines = file.readlines()

    with open(readme_path, 'w', encoding='utf-8') as file:
        for line in lines:
            if line.startswith("### 📘 Yechilgan masalalar:"):
                file.write(f"### 📘 Yechilgan masalalar: {count} ta ✅\n")
            else:
                file.write(line)

if __name__ == "__main__":
    count = count_solved_problems()
    update_readme(count)
    print(f"{count} ta masala topildi va README yangilandi.")
