<!-- resources/views/performance/summary.blade.php -->

@extends('layouts.app')

@section('content')
    <div class="container">
        <h1 class="mt-5 mb-4">Performance Summary</h1>

        <div class="mb-4">
            <a href="{{ route('checkin.show') }}" class="btn btn-primary">Check-in</a>
        </div>
        <table class="table table-bordered">
            <thead class="thead-dark">
                <tr>
                    <th>STT</th>
                    <th>Name</th>
                    <th>Hire Date</th>
                    <th>Total Hours Worked</th>
                    <th>Total Leave Days</th>
                    <th>Total Work Days</th>
                    <th>Leave Performance</th>
                    <th>Work Performance</th>
                    <th>Total Salary</th>
                </tr>
            </thead>
            <tbody>
                @foreach ($employeesPerformance as $employee)
                    <tr>
                        <td>{{ $employee->id }}</td>
                        <td>{{ $employee->name }}</td>
                        <td><small>{{ $employee->hire_date }}</small></td>
                        <td>{{ $employee->total_hours_worked }} hour</td>
                        <td>{{ $employee->total_leave_days }}/12d <br>Leave days:@if ($employee->leave_dates)
                                @php $leaveDates = explode(',', $employee->leave_dates); @endphp
                                @foreach ($leaveDates as $leaveDate)
                                    <small>{{ $leaveDate }},</small>
                                @endforeach
                            @else
                                No leave taken
                            @endif
                        </td>
                        <td>{{ $employee->total_work_days }}/225d</td>
                        <td>{{ calculateLeavePerformance($employee->total_leave_days) }} %</td>
                        <td>{{ calculateWorkPerformance($employee->total_work_days) }} %</td>
                        <td>{{ $employee->total_hours_worked * 50000 }} VNĐ</td>

                    </tr>
                @endforeach

            </tbody>
        </table>
    </div>
@endsection


@php
    function calculateWorkPerformance($total_work_days)
    {
        return round(($total_work_days / 225) * 100, 2);
    }

    function calculateLeavePerformance($total_leave_days)
    {
        return round(100 - ($total_leave_days / 12) * 100, 2);
    }
@endphp
