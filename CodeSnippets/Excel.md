# Excel issues

If the project fails to build, erroring out on references to Excel either check under project references to see if the version of Excel currently installed matches the version in this project. If the version does not match, uninstall the two references listed in bullet 2 and reinstall with the version of Excel on the current machine. If Excel is not installed follow the steps below.

1. Remove from Examples class, the method OpenExcel
2. Remove from project references
   - Microsoft.Office.Core
   - Microsoft.Office.Interop.Excel
3. Remove from the form, the GroupBox ExcelGroupBox and all related code.
   - ExcelSynchronousButton_Click
   - ExcelAsynchronousButton_Click
   

