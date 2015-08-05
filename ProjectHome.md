<b><u>About:</u></b><br>
BDAudioConverterGUI is inspired by BeLight,<br>
which unfortunately is no longer being developed.<br>
<br>
"BD" is the shortcut for BluRay and this format is the reason, that i've written this GUI.<br>
A lot of series or movies on BluRay are having the wrong pitch in the German-Audiostream.<br>
Fringe, Firefly, Prison Break etc.<br>
So I needed a tool, which can correct that for me and more.<br>I'm a beginner in C# and use this project to get some experience in programming.<br>
So, the code is a little mess ;-)<br>
<br>
BDAudioConverterGUI uses eac3to, SoX, Aften, Lame and NeroAACEnc to transcode<br>
audiofiles from their format to another.<br>
For this, it generates a cmd-file witch will be executed.<br>
So eac3to can pipe the audiostream to SoX and SoX can pipe the audiostream to<br>
another SoX-instance or to an ouput like Aften, Lame etc.<br>
The cmd-File is saved in the same folder like "BDAudioConverterGUI.exe". So you can see how it works.<br>
<br>
BDAudioConverterGUI has an option to change the tempo and the pitch.<br>
Downmixing from 5.1 to 2.0 is supported too.<br>
It allows to convert the samplingrate, the bitdepth and encoding type before adding<br>
effects and can change it back or to another setting, that fit an encoders input.<br>
<br>
Future features if I have time:<br>
<br>- Saved Settings -> done :-)<br>
<br>- Joblist<br>
<br>- Logging-System<br>
<br>
<br>
BDAudioConverterGUI comes without Nero AAC Encoder.<br>
Only Nero is allowed to distribute the encoder.<br>
You need to download it manualy from the official Nero website.<br>
<a href='http://www.nero.com/deu/technologies-aac-codec.html'>http://www.nero.com/deu/technologies-aac-codec.html</a>
Just copy "neroAacEnc.exe" to the "neroaacenc" folder.<br>
<br>
<br>
<b><u>Supported Input-Files:</u></b><br>
AC3, TrueHD, DTS, DTS-HD, WAV, FLAC<br>
<br>
For DTS-HD: Eac3to needs Arcsoft DTS decoder files.<br>
-> <a href='http://forum.doom9.org/showthread.php?p=1305698#post1305698'>http://forum.doom9.org/showthread.php?p=1305698#post1305698</a>


<b><u>Supported Output-Files:</u></b><br>
AAC, AC3, DTS, FLAC, MP3, WAV<br>
For encodings to DTS: Sometimes it works, sometimes not. It's still experimental.<br>
<br>
<b><u>Known issues:</u></b><br>
- Some AC3-decoders manipulate the audio like for DRC (Dynamic Range Compression)<br>
<blockquote>Have a look to: <a href='http://en.wikibooks.org/wiki/Eac3to/In_Depth_Technical_Explanation'>http://en.wikibooks.org/wiki/Eac3to/In_Depth_Technical_Explanation</a></blockquote>


<img src='http://www.3dfx.ch/bdaudioconverter/bdaudioconverter_preview.png' />

<b><u>Settings:</u></b><br>

<img src='http://www.3dfx.ch/bdaudioconverter/bdaudioconvertergui_sox_settings.gif' />  <img src='http://www.3dfx.ch/bdaudioconverter/bdaudioconvertergui_target_format.gif' />