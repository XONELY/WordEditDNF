# WordEdit
used packages: 
1) Mysql.Data 
2) GemBox.Document


# About 
My first project aimed at making my prev. job easier. I needed a program that would automatically fill out Word documents.
The first version of the program used HTMLAgilityPack to pars emloyeers personal data from company website.
But it was slow and also some data was missed/mixed up.
Therefore i decided to write personal data (for the employeers i need) in a CSV-file.
Then i wrote a code that reads the data line by line and assings it when creating object.
But it didnt look fine. 
Thats why i tried MySQL, first i had to transfer CSV-data to a table.
I wrote the code that writes data into the table line by line, 
Now i do not update this project, as it fulfils its function, but somewhere i would still change it.

