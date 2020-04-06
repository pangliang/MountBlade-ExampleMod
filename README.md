## 

### Disable Startup Title Screens
M&B Bannerlord How to Disable Startup Title Screens

Change the Filename
In your Steam folder find this directory:
~steamapps\common\Mount & Blade II Bannerlord\Modules\Native\Videos

Within it is a file called TWLogo_and_Partners.ivf
Rename this file (e.g. to TWLogo_and_Partners.ivf.noplay)

### No need to copy file to game dir
Make soft link dir to game mod dir

```bash
mklink /j "F:\Mount & Blade II Bannerlord\Modules\ExampleMod" F:\pangliang_workspace\ExampleMod\ExampleMod
```
