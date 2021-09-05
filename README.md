# Path.Combine path traversal vulnerability ASP.NET CORE
Study case for path traversal vulnerability on path.combine function in the asp.net core.

- Line 14 is the data input parameter to pass data to the vulnerable function.

- Line 21 is the vulnerable function that combining the temp path with the data input from the parameter.

- If you comment line 20 the code will be sanitized and the vulnerability will be fixed by using `Path.GetFileName();` to sanitize the file name.
