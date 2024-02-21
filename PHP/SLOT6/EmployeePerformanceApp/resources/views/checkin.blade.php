@extends('layouts.app')

@section('content')
    <div class="container">
        <h1 class="mt-5 mb-4">Check-in</h1>


        @if (session('success'))
            <div class="alert alert-success">
                {{ session('success') }}
            </div>
        @elseif(session('error'))
            <div class="alert alert-danger">
                {{ session('error') }}
            </div>
        @endif

        <form method="POST" action="{{ route('checkin.submit') }}">
            @csrf
            <div class="form-group">
                <label for="employee_id">Select Employee:</label>
                <select name="employee_id" class="form-control">
                    @foreach ($employees as $employee)
                        <option value="{{ $employee->id }}">ID: {{ $employee->id }} - Name: {{ $employee->name }}
                            - Date start work: {{ $employee->hire_date }}</option>
                    @endforeach
                </select>
            </div>
            <button type="submit" class="btn btn-primary">Check-in</button>
        </form>
    </div>
@endsection
