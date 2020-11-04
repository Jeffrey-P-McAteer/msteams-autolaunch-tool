
import os, sys, subprocess
import shutil

if __name__ == '__main__':
  if not shutil.which('dotnet'):
    print("Error: You need the 'dotnet' utility to compile this program!")
    sys.exit(1)

  subprocess.run(['dotnet', 'build'], check=True)
  
