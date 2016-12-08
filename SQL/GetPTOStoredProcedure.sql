/* This stored procedure asks for shift ID (e.g. 1, 2) and Group Name (e.g. 'Manufacturing' 
or 'Research and Development') and returns the login names, job titles, areas, hire dates and 
PTO amounts (both vacation and sick time) for all employees in that Group on that shift. 
It will accept a truncated group name, i.e. 'Manu' for Manufacturing. It uses the AdventureWorks 
dB downloaded from Microsoft. */

CREATE PROC uspGetPTOByShiftAndArea @ShiftID INT, @GroupName varchar(50)
AS
	SELECT E.LoginID, E.JobTitle, D.Name, E.HireDate, E.VacationHours, E.SickLeaveHours
	FROM HumanResources.EmployeeDepartmentHistory AS EDH INNER JOIN HumanResources.Employee AS E
		ON EDH.BusinessEntityID = E.BusinessEntityID
	INNER JOIN HumanResources.Department AS D
		ON EDH.DepartmentID = D.DepartmentID
	INNER JOIN HumanResources.[Shift] AS S
		ON EDH.ShiftID = S.ShiftID
	WHERE S.ShiftID = @ShiftID AND D.GroupName LIKE @GroupName + '%' AND EDH.EndDate IS NULL