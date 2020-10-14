$updateText = Read-Host "Enter update text: "

cd D:\Bootcamp
git add .
git commit -m $updateText
git push origin main
Read-Host "Press any key to continue..."