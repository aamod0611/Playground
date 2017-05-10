from django.views import generic
from django.views.generic.edit import CreateView,UpdateView,DeleteView
from django.core.urlresolvers import reverse_lazy
from . models import Album

# from django.shortcuts import render
# from django.http import HttpResponse
# from django.template import loader
# from . models import Album
# from django.http import Http404
# def index(request):
	# all_albums = Album.objects.all()
	# # html=''
	# # for album in all_albums:
		# # url = '' + str(album.id) + ''
		# # html += '<a href = "'+ url + '">' + album.title + '</a><br>'


	# #################################     either you can use "load" or "render"	     ################################33
	# # template = loader.get_template('index.html')
	# # context={
		# # 'all_albums' : all_albums,
	# # }
	# # return HttpResponse(template.render(context,request))
	# return render(request,'index.html', {'all_albums':all_albums})
	
# def detail(request, album_id):
	# try:
		# album = Album.objects.get(pk = album_id)
	# except Album.DoesNotExist:
		# raise Http404("album doesnot exist")
	# return render(request, 'detail.html', {'album': album})

class IndexView(generic.ListView):
	template_name = 'index.html'
	context_object_name = 'all_album'	
	def get_queryset(self):
		return Album.objects.all()
	
class DetailView(generic.DetailView):
	model = Album
	template_name = 'detail.html'
		
		
class AlbumCreate(CreateView):
	model = Album
	template_name = 'album_form.html'
	fields = ['artist','title','genre','album_logo']
		
class AlbumUpdate(UpdateView):
	model = Album
	template_name = 'album_form.html'
	fields = ['artist','title','genre','album_logo']		
		
class AlbumDelete(DeleteView):
	model = Album
	# = 'album_form.html'
	success_url = reverse_lazy('music:index')		
		
		
		
		
		
		
		
		
		
		
		