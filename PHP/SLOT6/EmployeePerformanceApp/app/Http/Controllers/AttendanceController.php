<?php

namespace App\Http\Controllers;

use App\Models\Attendance;
use App\Http\Requests\StoreAttendanceRequest;
use App\Http\Requests\UpdateAttendanceRequest;
use Illuminate\Http\Request;
use Carbon\Carbon;
use Illuminate\Support\Facades\DB;
use App\Models\Employee;


class AttendanceController extends Controller
{

    public function checkIn(Request $request)
    {
        $employeeId = $request->input('employee_id');

        $existingAttendance = Attendance::where('employee_id', $employeeId)
            ->whereDate('work_date', now()->toDateString())
            ->first();

        if ($existingAttendance) {
            return redirect()->route('checkin.show')->with('error', 'You have already checked in today.');
        }

        // Tạo mới bản ghi điểm danh
        Attendance::create([
            'employee_id' => $employeeId,
            'work_date' => now(),
            'hours_worked' => 8,
        ]);

        return redirect()->route('checkin.show')->with('success', 'Check-in successful.');
    }

    public function showCheckinForm()
    {
        $employees = Employee::all(); // Giả sử bạn đã có model Employee
        return view('checkin', compact('employees'));
    }

    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        //
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        //
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \App\Http\Requests\StoreAttendanceRequest  $request
     * @return \Illuminate\Http\Response
     */
    public function store(StoreAttendanceRequest $request)
    {
        //
    }

    /**
     * Display the specified resource.
     *
     * @param  \App\Models\Attendance  $attendance
     * @return \Illuminate\Http\Response
     */
    public function show(Attendance $attendance)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  \App\Models\Attendance  $attendance
     * @return \Illuminate\Http\Response
     */
    public function edit(Attendance $attendance)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \App\Http\Requests\UpdateAttendanceRequest  $request
     * @param  \App\Models\Attendance  $attendance
     * @return \Illuminate\Http\Response
     */
    public function update(UpdateAttendanceRequest $request, Attendance $attendance)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  \App\Models\Attendance  $attendance
     * @return \Illuminate\Http\Response
     */
    public function destroy(Attendance $attendance)
    {
        //
    }
}
