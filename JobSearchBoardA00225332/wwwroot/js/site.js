if ('clipboard' in navigator) {
    let canWriteClipboard = false; navigator.permissions.query({ name: 'clipboard-read' }).then((perms) => {
        canWriteClipboard = perms.state;
        if (canWriteClipboard === "granted") { $("#copyToClipboard").on('click', () => { navigator.clipboard.writeText(window.location.href); }) } else if (canWriteClipboard === "prompt") { $("#copyToClipboard").on('click', () => { $("#clipboardPerms").show(); }) } else { return; } $("#copyToClipboard").removeAttr('hidden');
    });
}
if ('caches' in window) {
    let offlineButton = $('#saveForOffline');
    if (offlineButton) {
        let isNotChached = false;
        offlineButton.on('click', async () => {
            let cache = await caches.open('offline-job-posts').then(async (cache) => {
                let isNotChached = await cache.match(window.location.href);
                let cacheMech = () => { cache.add(window.location.href); }
                if (isNotChached) {
                    offlineButton.val('💾 '); offlineButton.attr('aria-label', 'Save for offline')
                    cacheMech = () => { cache.delete(window.location.href); }
                } else { offlineButton.val(' ⃠'); offlineButton.attr('aria-label', 'Remove from cache') }
                cacheMech();
            })
        });
        (async function () {
            await caches.open('offline-job-posts').then(async (cache) => {
                cache.match(window.location.href).then((isNotCached) => {
                    if (isNotChached) { offlineButton.val(' ⃠'); offlineButton.attr('aria-label', 'Remove from cache') } else { offlineButton.val(' 💾'); offlineButton.attr('aria-label', 'Save for offline') }
                });
            })
        })();

    }
    offlineButton.removeAttr('hidden');    //document.querySelector("#saveForOffline").removeAttribute('hidden');
}