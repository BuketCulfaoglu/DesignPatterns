using Directory = CompositePattern.Directory;
using File = CompositePattern.File;


Directory directoryBase = new Directory();
File fileBase = new File(300);


Directory directorySub = new Directory();
File fileSub1 = new File(550);
File fileSub2 = new File(250);
directorySub.AddComponent(fileSub1);
directorySub.AddComponent(fileSub2);

directoryBase.AddComponent(fileBase);
directoryBase.AddComponent(directorySub);

Console.WriteLine($"Total Size of the Directory Base is : {directoryBase.GetSize()}" );

