<?php

include './config.php';

if (isset($_POST['student'])) {
    $name = $_POST['name'];
    $sql = "INSERT INTO student (full_name) VALUES ('$name')";
    $result = $conn->query($sql);
    if ($result) {
        echo "Student created successfully";
    } else {
        echo "Error: " . $sql . "<br>" . $conn->error;
    }
}

if (isset($_POST['subject'])) {
    $subject = $_POST['subject'];
    $sql = "INSERT INTO subject (subject_name) VALUES ('$subject')";
    $result = $conn->query($sql);
    if ($result) {
        echo "Subject created successfully";
    } else {
        echo "Error: " . $sql . "<br>" . $conn->error;
    }
}

if (isset($_POST['marks'])) {
    $student_id = $_POST['student_id'];
    $subject_id = $_POST['subject_id'];
    $mark = $_POST['mark'];

    $sql = "INSERT INTO mark (student_id, subject_id, mark) VALUES ('$student_id', '$subject_id', '$mark')";
    $result = $conn->query($sql);
    if ($result) {
        echo "New mark added successfully";

        $marks = fetchMarks($conn);

        foreach ($marks as $mark) {
            echo "<tr>
                    <td>{$mark['student_name']}</td>
                    <td>{$mark['subject_name']}</td>
                    <td>{$mark['mark']}</td>
                  </tr>";
        }
    } else {
        echo "Error: " . $sql . "<br>" . $conn->error;
    }
}

if ($_SERVER['REQUEST_METHOD'] === 'GET' && isset($_GET['student'])) {
    $marks = fetchMarks($conn);
    echo json_encode($marks);
}


function fetchMarks($conn)
{
    $sqlMarks = "SELECT student.full_name AS student_name, subject.subject_name, mark.mark
                  FROM student
                  LEFT JOIN mark ON student.id = mark.student_id
                  LEFT JOIN subject ON mark.subject_id = subject.id
                  WHERE mark.mark IS NOT NULL ORDER BY mark.id DESC";
    $resultMarks = $conn->query($sqlMarks);
    $marks = [];
    if ($resultMarks->num_rows > 0) {
        while ($row = $resultMarks->fetch_assoc()) {
            $marks[] = $row;
        }
    }
    return $marks;
}
