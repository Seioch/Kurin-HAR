import glob as glob
import os, shutil


texture_paths = glob.glob("C:\\Program Files (x86)\\Steam\\steamapps\\common\\RimWorld\\Mods\\Kurin-HAR\\Textures\\Kurin\\Head\\B\\*.png", recursive=True)

print(len(texture_paths))

# for path in texture_paths:
#     base, filename = os.path.split(path)
#     print(base)
#     print(filename)
#     if("Female" in filename):
#         new_filename = filename
#         # replace the Female with Male and resave the file
#         new_filename = new_filename.replace("Female", "Male")
#         print(new_filename)
#         shutil.copyfile(path, os.path.join(base, new_filename))
#     # break

# Replace the head texture names with ones for Male and Female
for path in texture_paths:
    base, filename = os.path.split(path)
    print(base)
    print(filename)
    # break
    new_filename_male = "Male_" + filename
    new_filename_female = "Female_" + filename
    shutil.copyfile(path, os.path.join(base, new_filename_male)) # clone all the existing non Male_ prefixed sprites and prefix them
    os.rename(path, os.path.join(base, new_filename_female)) # rename the female sprites to have Female_ prefix
    # break