<?php
include './config.php';
?>
<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1.0" />
  <title>Insert Data Form</title>
  <script src="https://code.jquery.com/jquery-3.6.4.min.js"></script>
  <style>
    body {
      font-family: Arial, sans-serif;
      margin: 20px;
      max-width: 500px;
      margin: 0 auto;
      padding: 10px;
    }

    h2 {
      color: #333;
    }

    form {
      margin-bottom: 20px;
    }

    label {
      display: block;
      margin-bottom: 5px;
    }

    input,
    select {
      margin-bottom: 10px;
      padding: 8px;
      width: 100%;
    }

    button {
      padding: 8px;
      background-color: #4caf50;
      color: white;
      border: none;
      cursor: pointer;
    }

    button:hover {
      background-color: #45a049;
    }

    table {
      border-collapse: collapse;
      width: 100%;
    }

    th,
    td {
      border: 1px solid #ddd;
      padding: 8px;
      text-align: left;
    }

    th {
      background-color: #4caf50;
      color: white;
    }
  </style>
</head>

<body>
  <h2>Add New Data</h2>

  <!-- Student Form -->
  <form id="studentForm">
    <label for="name">Student Name:</label>
    <input type="text" name="name" required />
    <input type="hidden" name="student" value="true" />
    <button type="button" onclick="submitForm('studentForm')">Add Student</button>
  </form>

  <!-- Subject Form -->
  <form id="subjectForm">
    <label for="subject">Subject Name:</label>
    <input type="text" name="subject" required />
    <button type="button" onclick="submitForm('subjectForm')">Add Subject</button>
  </form>

  <form id="markForm">
    <label for="student_id">Student:</label>
    <select name="student_id" required>
      <?php
      $studentQuery = "SELECT id, full_name FROM student";
      $studentResult = $conn->query($studentQuery);

      if ($studentResult->num_rows > 0) {
        while ($student = $studentResult->fetch_assoc()) {
          echo "<option value='{$student['id']}'>{$student['full_name']}</option>";
        }
      }
      ?>
    </select>

    <label for="subject_id">Subject:</label>
    <select name="subject_id" required>
      <?php
      $subjectQuery = "SELECT id, subject_name FROM subject";
      $subjectResult = $conn->query($subjectQuery);

      if ($subjectResult->num_rows > 0) {
        while ($subject = $subjectResult->fetch_assoc()) {
          echo "<option value='{$subject['id']}'>{$subject['subject_name']}</option>";
        }
      }
      ?>
    </select>

    <label for="mark">Mark:</label>
    <input type="text" name="mark" required>

    <input type="hidden" name="marks" value="true">
    <button type="button" onclick="submitForm('markForm')">Add Mark</button>
  </form>

  <h2> Marks</h2>
  <table border="1" id="marksTable">
    <thead>
      <tr>
        <th>Student Name</th>
        <th>Subject</th>
        <th>Mark</th>
      </tr>
    </thead>
    <tbody></tbody>
  </table>

  <script>
    function submitForm(formId) {
      var form = $('#' + formId);
      $.ajax({
        type: 'POST',
        url: "./dashboard.php",
        data: form.serialize(),
        dataType: 'html', // Specify the expected data type
        success: function(data) {
          $('#marksTable tbody').html(data);
        }
      });
    }


    $(document).ready(function() {
      $.ajax({
        type: 'GET',
        url: "./dashboard.php?student=true",
        dataType: 'json',
        success: function(data) {
          // Generate HTML for the initial history marks
          var html = '';
          data.forEach(function(mark) {
            html += "<tr><td>" + mark.student_name + "</td><td>" + mark.subject_name + "</td><td>" + mark.mark + "</td></tr>";
          });
          $('#marksTable tbody').html(html);
        }
      });
    });
  </script>

</body>

</html>