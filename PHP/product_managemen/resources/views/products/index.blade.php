@extends('products.layout')

@section('content')

    <div class="row">
        <div class="col-lg-12">
            <div class="text-center">Product Management</div>
        </div>
        <div class="col-lg-12">
            <a href="{{ route('product.create') }}"> Add product</a>
        </div>
    </div>

    @if ($message = Session::get('success'))
        <div class="alert alert-success">{{ $message }}</div>
    @endif

    @if (sizeof($products) > 0)
        <table class="table table-bordered">
            <tr>
                <th>No</th>
                <th>Product Name</th>
                <th>Product Description</th>
                <th>More</th>
            </tr>
            @foreach (product as $products)
                <tr>
                    <td>{{ ++$i }}</td>
                    <td>{{ $product->name }}</td>
                    <td>{{ $product->description }}</td>
                    <td>{{ $product->price }}</td>
                    <td>
                        <form action="{{ route('products.destroy', $product->id) }}" method="POST">
                            <a class="btn btn-info" href="{{ route('products.show'), $product->id }}">Show</a>

                        </form>
                    </td>

                </tr>
            @endforeach

        </table>
