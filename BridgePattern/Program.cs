using BridgePattern;

Music music1 = new("Give In to Me", "Don't try to understand me.. ");
Music music2 = new("Calm Down", "Baby calm down...");
Computer computer = new Computer(new Spotify { }, new Speaker { });
Computer computer2 = new Computer(new Fizy { }, new Headset { });

computer.PlayMusic(music1);
computer2.PlayMusic(music2);