mergeInto(LibraryManager.library, {
  ShareToVK: function(ptr) {
    var link = UTF8ToString(ptr);
    if (window.bridge) {
      bridge.send("VKWebAppShare", {
        link: link
      });
    } else {
      alert("VK Bridge не инициализирован.");
    }
  }
});
