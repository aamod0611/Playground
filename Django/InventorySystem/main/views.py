from django.shortcuts import render
from django.views.generic.edit import CreateView,UpdateView,DeleteView
from django.core.urlresolvers import reverse_lazy
from django.views import generic
from . models import Product , Sales_entry , categories

class IndexView(generic.ListView):
    template_name = 'index.html'
    context_object_name = 'all_products'
    def get_queryset(self):
        return Product.objects.all()

# class ProductDetail(generic.ListView):
#     model = Product
#     template_name = 'ProductDetails.html'
#     #fields = ['ProductCode','ProductName','Category','UnitPrice','QtyInStock','IsDiscontinued','ReOrderLevel']
#     context_object_name = 'all_products'
#
#     def get_queryset(self):
#         return Product.objects.all()


class ProductAdd(CreateView):
    model = Product
    template_name = 'ProductDetails.html'
    fields = ['ProductCode', 'ProductName', 'Category', 'UnitPrice', 'QtyInStock', 'IsDiscontinued', 'ReOrderLevel']


class SalesAdd(CreateView):
    model = Sales_entry
    template_name = 'SalesDetails.html'
    fields = ['Category','Product','QtySold','Rate']


class ProductUpdate(UpdateView):
    model = Product
    template_name = 'ProductDetails.html'
    fields = ['ProductCode', 'ProductName', 'Category', 'UnitPrice', 'QtyInStock', 'IsDiscontinued', 'ReOrderLevel']


class ProductDelete(DeleteView):
    model = Product
    # = 'album_form.html'
    success_url = reverse_lazy('main:index')

class categoryAdd(generic.ListView):
    model = categories
    template_name = 'ProductDetails.html'
    context_object_name = 'all_categories'

    def get_queryset(self):
        return categories.objects.all()
