
// Upon clicking the "Submit" button on index.html
$("#btnCalculate").click(function () {

    // Initialize variables
    var assignments
    var grpProject
    var quizzes
    var midterm
    var final
    var intex

    // If input isn't empty, multiply by appropriate percentage of total grade (from syllabus). Otherwise, set variable to 0.
    if ($("#txtAssignments").val() != "") {
        var assignments = parseFloat($("#txtAssignments").val()) * 0.5
    }
    else { var assignments = 0 }

    if ($("#txtGrpProject").val() != "") {
        var grpProject = parseFloat($("#txtGrpProject").val()) * 0.1
    }
    else { var grpProject = 0 }

    if ($("#txtQuizzes").val() != "") {
        var quizzes = parseFloat($("#txtQuizzes").val()) * 0.1
    }
    else { var quizzes = 0 }

    if ($("#txtMidterm").val() != "") {
        var midterm = parseFloat($("#txtMidterm").val()) * 0.1
    }
    else { var midterm = 0 }

    if ($("#txtFinal").val() != "") {
        var final = parseFloat($("#txtFinal").val()) * 0.1
    }
    else { var final = 0 }

    if ($("#txtIntex").val() != "") {
        var intex = parseFloat($("#txtIntex").val()) * 0.1
    }
    else { var intex = 0 }

    //Calculate overall percentage by summing percentages
    var overallPercent = (assignments + grpProject + quizzes + midterm + final + intex).toFixed(1)

    // Check for out of range totals (negative numbers or numbers greater than 100)
    if ((overallPercent > 100) || (overallPercent < 0)) {
        alert("Your total grade percentage has to be between 0 and 100. Please adjust your inputs and submit again :)")
    }
    // Check for NaN (non-number inputs)
    else if (isNaN(overallPercent)){
        alert("Please only input numbers!")
    }
    // Inputs must be valid
    else {

        // Assign html variable so that the total percentage appears
        $("#overallPercent").html(overallPercent + "%")

        // Calculate letter grade based on overall percent
        var letterGrade
        if (overallPercent < 60) {letterGrade = "E"}
        else if (overallPercent < 64) {letterGrade = "D-"}
        else if (overallPercent < 67) {letterGrade = "D"}
        else if (overallPercent < 70) {letterGrade = "D+"}
        else if (overallPercent < 74) {letterGrade = "C-"}
        else if (overallPercent < 77) {letterGrade = "C"}
        else if (overallPercent < 80) {letterGrade = "C+"}
        else if (overallPercent < 84) {letterGrade = "B-"}
        else if (overallPercent < 87) {letterGrade = "B"}
        else if (overallPercent < 90) {letterGrade = "B+"}
        else if (overallPercent < 94) {letterGrade = "A-"}
        else {letterGrade = "A"}

        // Assign html variable so that the letter grade appears
        $("#letterGrade").html(letterGrade)
    }


    
})
