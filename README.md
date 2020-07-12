# trlt
Simple console utility to easily transliterate filenames from cyrillic to english.
If you found a problem with the program please open issue.

## How to use
I recommend to add this utility to your PATH.
To use it just type `trlt value`. Instead of value you can put filename that you want to transliterate,
directory name in which case all cyrillic-named files in this directory will be transliterated.
If program can't find specified file or directory it just transliterate specified string.
You also can specify several arguments at one call.

### Examples
1. `trlt %USERPROFILE%/МойТекстовыйФайл.txt` will transliterate specified filename into MojTekstovyjFajl.txt.
2. `trlt %USERPROFILE%/MyDirectoryWithRussianNamedFiles` will transliterate all files inside specified directory.
3. `trlt dirname файл.ext строка` will transliterate all files in dirname, файл and show stroka.

##TODO
I want to add some options:
* `-h` to show help.
* `-s` to specify should program replace spaces with underscores.
* `-r` to specify should program transliterate files in directories recursively.
* `.` that tells program to transliterate all files in current directory.
* `..` to transliterate all files in upper directory.
