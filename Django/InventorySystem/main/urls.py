from django.conf.urls import url
from . import views
app_name = 'main'

urlpatterns = [
         url(r'^$', views.IndexView.as_view(), name='index'),
         url(r'^(?P<pk>[0-9]+)$', views.IndexView.as_view(), name='index'),
        # url(r'^main/product-Entry/$', views.ProductDetail.as_view(), name='product-Detail'),
         url(r'^main/product-Entry/$', views.ProductAdd.as_view(), name='product-Entry'),
         url(r'^main/categories/$', views.categoryAdd.as_view(), name='category'),
         url(r'^album/(?P<pk>[0-9]+)/$', views.ProductUpdate.as_view(), name = 'product-update'),
	     url(r'^album/(?P<pk>[0-9]+)/delete/$', views.ProductDelete.as_view(), name = 'product-delete'),
         url(r'^main/Sales-entry/$', views.SalesAdd.as_view(), name='Sales-Entry'),
        ]